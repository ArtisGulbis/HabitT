import { Formik, Form, ErrorMessage } from 'formik';
import React from 'react';
import { Button, Header } from 'semantic-ui-react';
import * as Yup from 'yup';
import MyTextInput from '../../app/common/form/MyTextInput';
import ValidationErrors from '../errors/ValidationErrors';

const RegisterForm = () => {
  return (
    <Formik
      initialValues={{
        displayName: '',
        username: '',
        email: '',
        password: '',
        error: null,
      }}
      onSubmit={(values, { setErrors }) => {
        console.log(values);
      }}
      validationSchema={Yup.object({
        displayName: Yup.string().required(),
        username: Yup.string().required(),
        email: Yup.string().required(),
        password: Yup.string().required(),
      })}
    >
      {({ handleSubmit, isSubmitting, errors, isValid, dirty }) => (
        <Form
          className="ui form error"
          autoComplete="off"
          onSubmit={handleSubmit}
        >
          <Header
            as="h2"
            content="Sign up for habit tracker"
            color="teal"
            textAlign="center"
          />
          <MyTextInput name="displayName" placeholder="Display Name" />
          <MyTextInput name="username" placeholder="Username" />
          <MyTextInput name="email" placeholder="Email" />
          <MyTextInput name="password" placeholder="Password" type="password" />
          <ErrorMessage
            name="error"
            render={() => <ValidationErrors errors={errors.error} />}
          />
          <Button
            loading={isSubmitting}
            disabled={!dirty || !isValid || isSubmitting}
            positive
            content="Register"
            type="submit"
            fluid
          />
        </Form>
      )}
    </Formik>
  );
};

export default RegisterForm;
