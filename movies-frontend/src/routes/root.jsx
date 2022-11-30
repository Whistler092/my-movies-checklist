import { Outlet } from "react-router";

export default function Root() {
  return (
    <>
      <div id="header">
        <h1>React Movies</h1>
      </div>
      <div id="detail">
        <Outlet />
      </div>
    </>
  );
}
