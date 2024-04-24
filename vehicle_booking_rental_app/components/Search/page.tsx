"use client";
import React from "react";
import { SearchManufacturer } from "../../components";
import { useState } from "react";

const Search = () => {
  const [manufacturer, setManuFacturer] = useState("");
  const [model, setModel] = useState("");
  const handleSearch = () => {};

  return (
    <form className="searchbar" onSubmit={handleSearch}>
      <div className="searchbar__item">
        <SearchManufacturer 
          manufacturer={manufacturer}
          setManufacturer={setManuFacturer}
        />
      </div>
    </form>
  );
};

export default Search;
