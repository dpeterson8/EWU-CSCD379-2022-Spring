<template>
  <v-row>
    <v-col class="text-center">
      <v-card
        elevation="5"
        outlined
      >
      <v-card-title>
        The Name of the Game!
      </v-card-title>
      <v-card-text>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
        labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
        nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate 
        velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, 
        sunt in culpa qui officia deserunt mollit anim id est laborum.
      </v-card-text>
      <v-btn
        color="primary"
        elevation="2"
        nuxt to="/"
      >
        Click to return home
      </v-btn>
      </v-card>
    </v-col>
  </v-row>
</template>

<script lang="ts">
import Vue from "vue"
import Component from "vue-class-component"

@Component
export default class GamePage extends Vue{
    name: string = 'GamePage';
}
</script>