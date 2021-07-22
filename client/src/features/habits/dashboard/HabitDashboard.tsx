import React from 'react';
import { Grid, List } from 'semantic-ui-react';
import { Habit } from '../../../app/models/habit';

interface Props {
  habits: Habit[];
}

const HabitDashboard = ({ habits }: Props) => {
  return (
    <Grid>
      <Grid.Column width={10}>
        <List>
          {habits.map((habit: Habit) => (
            <List.Item key={habit.id}>{habit.habitName}</List.Item>
          ))}
        </List>
      </Grid.Column>
    </Grid>
  );
};

export default HabitDashboard;
