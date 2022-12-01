import axios from "axios";
import { useEffect, useState } from "react";
import "./movies.scss";

export default function Movies() {
  const [movies, setMovies] = useState([]);

  useEffect(() => {
    axios
      .get("db.json")
      .then((res) => setMovies(res.data))
      .catch((err) => console.error(err));
  }, []);

  return (
    <>
      <div className="films">
        {movies &&
          movies?.results?.map((film) => <Film key={film.id} film={film} />)}
      </div>
    </>
  );
}

function Film({ film }) {
  return (
    <div key={film.id} className="film">
      <img
        src={`https://image.tmdb.org/t/p/w185_and_h278_bestv2${film.poster_path}`}
      ></img>
      <span>{film.original_title}</span>
    </div>
  );
}
