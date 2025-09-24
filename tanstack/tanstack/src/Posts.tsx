import { useQuery } from "@tanstack/react-query";
//https://jsonplaceholder.typicode.com/users
interface Post {
  userId: number;
  id: number;
  title: string;
  body: string;
}
const fetchPosts = async () => {
  const response = await fetch("https://jsonplaceholder.typicode.com/posts");
  if (!response.ok) throw new Error("error fetching data");
  return response.json();
};

function Posts() {
  const { data, isLoading, isError, error } = useQuery<Post[]>({
    queryKey: ["posts"],
    queryFn: fetchPosts,
    staleTime: 10000,
  });
  if (isLoading) return <p>Loading...</p>;
  if (isError) return <p>Error occured: {error.message}</p>;
  return (
    <>
      {data?.map((post) => {
        return <p key={post.id}>{post.title}</p>;
      })}
    </>
  );
}

export default Posts;
