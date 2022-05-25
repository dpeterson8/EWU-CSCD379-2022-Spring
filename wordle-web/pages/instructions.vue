<template>
  <v-container>
    <v-row justify="center">
      <!-- Back Button -->
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

      <!-- Game Info Card(s) -->
      <v-col cols="12">
        <v-card flat color="transparent">
          <v-card-title class="justify-center">
            <h1>!Wordle</h1>
          </v-card-title>
        </v-card>
      </v-col>

      <!-- Game Card -->
      <v-col cols="8">
        <v-card>
          <div class="d-flex align-center">
            <v-icon size="150" class="ma-6">mdi-file-word-box</v-icon>
            <v-card-text decoration>
              Not Wordle (stylized as <em>!Wordle</em>), is a web development
              course-based game <em>heavily</em> inspired by
              <em
                ><a href="https://en.wikipedia.org/wiki/Josh_Wardle"
                  >Josh Wardle</a
                >'s</em
              >
              viral creation
              <a href="https://www.nytimes.com/games/wordle/index.html"
                >Wordle</a
              >.
              <v-spacer />
              Clearly, this is not the same game, but rather a unique spin on
              the new classic written by students at
              <a href="https://www.ewu.edu">Eastern Washington University</a>
              learning .NET web application development.
            </v-card-text>
          </div>
        </v-card>
      </v-col>

      <!-- Instructor Cards -->
      <v-col cols="12">
        <v-card flat color="transparent">
          <v-card-title class="justify-center">
            <h1>Instructors</h1>
          </v-card-title>
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
