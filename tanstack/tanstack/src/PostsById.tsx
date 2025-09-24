import { useQuery } from "@tanstack/react-query";
//https://jsonplaceholder.typicode.com/users
interface Post {
  userId: number;
  id: number;
  title: string;
  body: string;
}
const fetchPosts = async (id: number) => {
  const response = await fetch(
    `https://jsonplaceholder.typicode.com/posts/${id}`
  );
  if (!response.ok) throw new Error("error fetching data");
  return response.json();
};

function PostsById({ id }: { id: number }) {
  const { data, isLoading, isError, error } = useQuery<Post>({
    queryKey: ["post", id],
    queryFn: () => fetchPosts(id),
    staleTime: 10000,
  });
  if (isLoading) return <p>Loading...</p>;
  if (isError) return <p>Error occured: {error.message}</p>;
  return (
    <>
      <p>{data?.title}</p>
    </>
  );
}

export default PostsById;
