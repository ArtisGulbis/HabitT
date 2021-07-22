import React, { useEffect, useState } from 'react';
import { Habit } from '../models/habit';
import HabitDashboard from '../../features/habits/dashboard/HabitDashboard';
import agent from '../api/agent';
import LoadingComponent from './LoadingComponent';
import LoginForm from '../../features/users/LoginForm';
import RegisterForm from '../../features/users/RegisterForm';
import { Route, Switch } from 'react-router-dom';
import HomePage from '../../features/home/HomePage';
import { Container, ModalContent } from 'semantic-ui-react';
import ModalContainer from '../../features/modals/ModalContainer';

function App() {
  const [habits, setHabits] = useState<Habit[]>([]);
  const [loading, setLoading] = useState(true);
  useEffect(() => {
    // agent.Habits.list().then((res) => {
    //   setHabits(res);
    //   setLoading(false);
    // });
  }, []);

  if (loading) {
    // return <LoadingComponent />;
  }
  // return <div>{/* <HabitDashboard habits={habits} /> */}</div>;
  return (
    <>
      <Route exact path="/" component={HomePage} />
      <ModalContainer />
      <Route
        path="/(.+)"
        render={() => (
          <>
            <Container style={{ marginTop: '7em' }}>
              <Switch>
                <Route exact path="/login" component={LoginForm} />
                <Route exact path="/register" component={RegisterForm} />
              </Switch>
            </Container>
          </>
        )}
      />
    </>
  );
}

export default App;
