import React from 'react';
import './App.css';
import Header from './Header';
import FoodList from './Food/FoodList';

function App() {
  return (
    <div className="App">
      <Header title="Full Stack React & ASP.NET" />
      <br />
      <FoodList />
    </div>
  );
}

export default App;
