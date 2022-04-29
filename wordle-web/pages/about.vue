<template>
  <v-container fluid fill-height justify-center>
    <v-row justify="center" align="center">
      <v-card color="slate">
        <v-card-title class="display-1">
          CSCD379 Wordle
        </v-card-title>
        <v-card-text class="body-2">
          Welcome to our Wordle Page made for our CSCD379 class!<br/>
          This project is meant to help teach us about and give <br/>
          us hands-on experience creating a web application using <br/>
          a multitude of different tools. <br/>
          Meg is our class grader and she is amazing! She is very </br>
          nice and always available to provide help for students. <br/>
        </v-card-text>

        <v-card-text class="body-2">
          Don't know how to play Wordle? Check the rules below!<br/>
          <br/>
          Objective:<br/>
          1) Guess the correct five letter word.<br/>
          2) Guess in as few attempts as possible!<br/>
          <br/>
          Da Rules:<br/>
          1) Each of your guesses needs to be a real word. <br/>
          2) Different colors on your letters have different meanings:<br/>
             > Grey: The letter is NOT found anywhere in the word. <br/>
             > Yellow: The letter IS found in the word, however the <br />
                       position is wrong. <br/>
             > Green: The letter is in the word and the right position. <br />
          3) The same letter can appear in the word multiple times.<br />
          4) You have a maximum of six attempts to guess the word.

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
    name: string = 'AboutPage';
  }
</script>
