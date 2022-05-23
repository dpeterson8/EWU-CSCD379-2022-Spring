<template>
  <v-row>
    <v-col class="text-center">
      <CandidateDisplay />
    </v-col>
  </v-row>
</template>

<script lang="ts">
import Vue from "vue"
import Component from "vue-class-component"

@Component
export default class InspirePage extends Vue{
    name: string = 'InspirePage';
}
</script>
