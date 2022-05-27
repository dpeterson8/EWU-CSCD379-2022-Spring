<template>
  <v-container>
    <v-row justify="center">
      
      <v-col cols="1">
        <v-btn
          fab
          v-bind="attrs"
          color="primary"
          v-on="on"
          @click="$router.go(-1)"
        >
          <v-icon>mdi-arrow-left</v-icon>
        </v-btn>
      </v-col>

      
      <v-col cols="12">
        <v-card flat color="transparent">
          <v-card-title class="justify-center">
            <h1>Instructions</h1>
          </v-card-title>
        </v-card>
      </v-col>

      
      <v-col cols="8">
        <v-card>
          <div class="d-flex align-center">
            <v-icon size="150" class="ma-6 testIcon">mdi-file-word-box</v-icon>
            <v-card-text decoration>  
                Never played wordle? No problem, here are all the needed
                rules and instructions to play wordle:
                <br/> 1. Everyday wordle will have a random word you are meant to guess!
                <br/> 2. You will have five guesses for each word.
                <br/> 3. When guessing a word characters can be represented by a green, yellow, or red background.
                <br/>   green - character is in word and in correct location.
                <br/>   yellow - character is in word but in the wrong location.
                <br/>   red - character is not present in word.
            </v-card-text>
          </div>
        </v-card>
      </v-col>

    </v-row>
  </v-container>
</template>

<script>
import Vue from 'vue'
import Component from 'vue-class-component'

@Component
export default class InstructionsPage extends Vue {}
</script>

<style scoped>

  @media (max-width: 640px) {
    .testIcon{
      display: none;
    }
  }

  body{
    background: red;
  }

</style>
