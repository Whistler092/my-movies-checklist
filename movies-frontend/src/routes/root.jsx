import { Outlet } from "react-router";
import { NavLink } from "react-router-dom";
import "./root.scss";

export default function Root() {
  return (
    <>
      <div id="header" className="header">
        <ul>
          <li key="Movies">
            <NavLink to="Movies">Movies</NavLink>
          </li>
          <li key="Comments">
            <NavLink to="Comments">Comments</NavLink>
          </li>
          <li key="Profile">
            <NavLink to="Profile">Profile</NavLink>
          </li>
          <div className="dot"></div>
        </ul>
      </div>
      <div id="detail">
        <Outlet />
      </div>
    </>
  );
}
