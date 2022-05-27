<template>
  <v-container fluid fill-height justify-center>
    <v-card>
      <v-card-title class="display-3 justify-center">
        Daily Word Stats
      </v-card-title>
      <v-card-text class="text-center">
        {{ title }}
      </v-card-text>
      <v-card-text>
        <v-simple-table>
          <thead>
            <tr>
              <th style="text-align: center"># of Plays</th>
              <th style="text-align: center">Avg. Score</th>
              <th style="text-align: center">Avg. Seconds</th>
            </tr>
          </thead>
        </v-simple-table>
      </v-card-text>

    </v-card>
  </v-container>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator'

@Component({})
export default class dailyWord extends Vue {
  words: any = []
  title: string = ''

  created() {
    this.getTop10Words()
  }

  getTop10Words() {
    this.title = '10 daily Words'
    this.$axios.get('/api/Words').then((response) => {
      this.words = response.data
    })
  }
}
</script>
