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
            <v-icon size="150" class="ma-6">mdi-file-word-box</v-icon>
            <v-card-text decoration>  
                Never played wordle? No problem, here are all the needed
                rules and instructions to play wordle:
                 1.
                 2.
                 3.
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
