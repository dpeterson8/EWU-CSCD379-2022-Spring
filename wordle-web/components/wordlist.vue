<template>
  <v-card class="my-5 pa-5">
    <v-btn
    @click="findWord(wordCheck)"
    >
      <v-icon>mdi-backspace</v-icon>
    </v-btn>

    <v-btn
    @click="showDisplay()"
    >
      {{ wordListLength() }}
    </v-btn>

      <v-list v-if="displayList()">
        <v-list-item
          v-for="item in findWord(wordCheck)"
          :key="item"
        >
          <v-list-item-content>
            <v-list-item-title v-text="item"></v-list-item-title>
          </v-list-item-content>

        </v-list-item>
      </v-list>
  </v-card>
</template>

<script lang="ts">
import { Component, Vue, Prop } from 'vue-property-decorator'
import { WordsService } from '~/scripts/wordsService'
import { Word } from '~/scripts/word'

@Component
export default class WordList extends Vue {
    wordList!: string[]
    display!: boolean
    @Prop({ required: true })
    wordCheck!: Word

    findWord(word: string) {
      this.wordList = []
      var tempList = WordsService.wordList;
      var newList:string[] = [];
      var check = true;
      tempList.forEach(x => {

        var temp = x.split(''); 
        var i = 0;
        this.wordCheck.text.split('').forEach(e => {
          if(e === temp[i] || e === '?') {

          } else {
              check = false
          }
          i++;
        });
        if(check == true) {
          newList.push(x) 
        }
        else {check = true}

      });

      return newList;
    }

    wordListLength() {
      return this.findWord(this.wordCheck.text).length
    }

    showDisplay(){
      this.display = true;
    }

    displayList() {
      return this.display;
    }
}
</script>
