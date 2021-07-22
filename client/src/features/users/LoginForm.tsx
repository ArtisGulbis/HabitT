import React from 'react';
import { Formik, Form, ErrorMessage } from 'formik';
import { Button, Header, Label } from 'semantic-ui-react';
import MyTextInput from '../../app/common/form/MyTextInput';

const LoginForm = () => {
  return (
    <Formik
      initialValues={{ email: '', password: '', error: null }}
      onSubmit={(values, { setErrors }) => {
        console.log(values);
      }}
    >
      {({ handleSubmit, isSubmitting, errors }) => (
        <Form className="ui form" autoComplete="off" onSubmit={handleSubmit}>
          <Header
            as="h2"
            content="Login to habit tracker"
            color="teal"
            textAlign="center"
          />
          <MyTextInput name="email" placeholder="Email" />
          <MyTextInput name="password" type="password" placeholder="Password" />
          <ErrorMessage
            name="error"
            render={() => (
              <Label
                style={{ marginBottom: 10 }}
                basic
                color="red"
                content={errors.error}
              />
            )}
          />
          <Button
            loading={isSubmitting}
            positive
            content="Login"
            type="submit"
            fluid
          />
        </Form>
      )}
    </Formik>
  );
};

export default LoginForm;
