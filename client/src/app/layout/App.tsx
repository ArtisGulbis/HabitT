import React, { useEffect, useState } from 'react';
import { Habit } from '../models/habit';
import HabitDashboard from '../../features/habits/dashboard/HabitDashboard';
import agent from '../api/agent';
import LoadingComponent from './LoadingComponent';

function App() {
  const [habits, setHabits] = useState<Habit[]>([]);
  const [loading, setLoading] = useState(true);
  useEffect(() => {
    agent.Habits.list().then((res) => {
      setHabits(res);
      setLoading(false);
    });
  }, []);

  if (loading) {
    return <LoadingComponent />;
  }
  return (
    <div>
      <HabitDashboard habits={habits} />
    </div>
  );
}

export default App;
