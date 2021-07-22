import { observer } from 'mobx-react-lite';
import React from 'react';
import { Button, Container, Grid, Header, Segment } from 'semantic-ui-react';
import { useStore } from '../../app/stores/store';
import LoginForm from '../users/LoginForm';
import RegisterForm from '../users/RegisterForm';

const HomePage = () => {
  const { modalStore } = useStore();
  return (
    <Segment
      inverted
      color="blue"
      textAlign="center"
      vertical
      style={{
        width: '100%',
        height: '100vh',
        display: 'flex',
        alignItems: 'center',
      }}
      className="masthead"
    >
      <Container text>
        <Grid>
          <Grid.Column width={16} textAlign="center">
            <Header as="h1" inverted>
              Habit Tracker
            </Header>
            <Button
              onClick={() => modalStore.openModal(<LoginForm />)}
              size="huge"
              inverted
              content="Login"
            />
            <Button
              onClick={() => modalStore.openModal(<RegisterForm />)}
              size="huge"
              inverted
              content="Register"
            />
          </Grid.Column>
        </Grid>
      </Container>
    </Segment>
  );
};

export default observer(HomePage);
