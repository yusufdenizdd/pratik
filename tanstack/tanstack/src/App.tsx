import "./App.css";
import { useState } from "react";
import Posts from "./Posts";
import PostsById from "./PostsById";

function App() {
  const [isMounted, setIsMounted] = useState(false);
  return (
    <>
      <button onClick={() => setIsMounted((prev) => !prev)}>Toggle</button>

      {isMounted && <Posts />}
      <PostsById id={1} />
    </>
  );
}

export default App;
