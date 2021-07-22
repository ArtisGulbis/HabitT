import React, { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';
import { List } from 'semantic-ui-react';

function App() {
  const [days, setDays] = useState([]);
  useEffect(() => {
    axios
      .get('http://localhost:5000/api/days')
      .then((res) => setDays(res.data));
  }, []);
  return (
    <div>
      {days.map((day: any) => (
        <List key={day.dayNumber}>
          <List.Item>{day.dayNumber}</List.Item>
        </List>
      ))}
    </div>
  );
}

export default App;
