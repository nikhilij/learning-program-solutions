import React from 'react';
import '../Stylesheets/mystyle.css';

function CalculateScore() {
  // Sample data (you can later replace with props or form input)
  const name = "Anisha Raj";
  const school = "Springfield High";
  const total = 450;
  const goal = 5;

  const average = total / goal;

  return (
    <div className="score-box">
      <h1>Score Calculator</h1>
      <p><strong>Name:</strong> {name}</p>
      <p><strong>School:</strong> {school}</p>
      <p><strong>Total Marks:</strong> {total}</p>
      <p><strong>Goal Subjects:</strong> {goal}</p>
      <p><strong>Average Score:</strong> {average.toFixed(2)}</p>
    </div>
  );
}

export default CalculateScore;
