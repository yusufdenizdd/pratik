import { useMutation, useQueryClient } from "@tanstack/react-query";
import { useState } from "react";

const createPost = async (newPost) => {
  const response = await fetch("https://jsonplaceholder.typicode.com/posts", {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(newPost),
  });

  return response.json();
};

export const CreatePost = () => {
  const [title, setTitle] = useState("");
  const queryClient = useQueryClient();

  const { mutate } = useMutation({
    mutationFn: createPost,
    onSuccess: () => {
      queryClient.invalidateQueries({ queryKey: ["posts"] }); //get ile çektigimiz veriler eski kalmasın diye bidaha refetch atıcak
    },
    // onSuccess: (data) => {
    //   console.log("Backend’in oluşturduğu ID ve veri:", data);
    // örnek: { id: 101, title: "...", body: "...", userId: 1 }
    // },
    onMutate: async (newPost) => {
      await queryClient.cancelQueries(["posts"]);
      const previousPosts = queryClient.getQueriesData(["posts"]);
      queryClient.setQueryData(["posts"], (old) => [
        ...old,
        { id: Date.now(), ...newPost },
      ]);
      return { previousPosts };
    },
    onError: (err, newPost, context) => {
      queryClient.setQueryData(["posts"], context?.previousPosts);
    },
  });
  const handleSubmit = (e) => {
    e.preventDefault();
    mutate({ title, body: "This is a new post" });
  };
  return (
    <>
      <form>
        <input
          onChange={(e) => setTitle(e.target.value)}
          type="text"
          placeholder="post title..."
        />
        <button onClick={handleSubmit}>create post</button>
      </form>
    </>
  );
};
