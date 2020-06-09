<template>
  <div>
    <label>Username</label>
    <input type="text" v-model="username" />
    <br />
    <br />
    <label>Password</label>
    <input type="password" v-model="password" />
    <br />
    <br />
    <button v-on:click="login">Login</button>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: "Login",
  data() {
    return {
      username: undefined,
      password: undefined
    };
  },
  methods: {
    login() {
      axios
        .post("https://localhost:44355/login", {
          username: this.username,
          password: this.password
        })
        .then(
          response => {
            console.log(response);
          },
          error => {
            console.log(error);
          }
        );
    }
  }
};
</script>

<style scoped>
</style>>