<template>
  <v-container fluid fill-height justify-center>
    <v-row justify="center" align="center">
      <v-card color="slate">
        <v-card-title class="display-1">
          CSCD379 Wordle
        </v-card-title>
        <v-card-text class="body-2">
          Welcome to our Wordle about page!<br/>
          This project is meant to help teach us about and give <br/>
          us hands-on experience creating a web application using <br/>
          a multitude of different tools. <br/>
          Meg is our class grader and she is amazing! <br/>
        </v-card-text>

        <v-card-text class="body-2">
          Don't know how to play Wordle? Check the rules below!<br/>
          <br/>
          How to play:<br/>
          1) Each of guess must be a real word. <br/>
          2) Enter your 5 letter word into the keyboard on screen.<br/>
          3) Once you enter you word the following colors can mean:<br />
            GREEN - Correct letter in the correct position<br />
            YELLOW - Correct letter in the following position <br />
            RED - Letter not in the word. <br />
          4) Once the word is guessed correct an alert will appear

        </v-card-text>
        
      </v-card>

    </v-row>
  </v-container>
</template>

<script lang="ts">
  import Vue from "vue"
  import Component from "vue-class-component"

  @Component
  export default class AboutPage extends Vue {

}
</script>
