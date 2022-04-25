<template>
  <v-card>

    <v-btn
    fab
    @click="showDisplay()"
    >
      {{ wordListLength() }}
    </v-btn>

      <v-virtual-scroll
          :bench="benched"
          :items="findWord(wordCheck)"
          v-if="display"
          height="300"
          width = "150"
          item-height="64"
        >
          <template v-slot:default="{ item }">
            <v-list-item :key="item">
              <v-list-item-action>
                <v-btn
                  depressed
                  color="primary"
                  @click="selectWord(item)"
                >
                  {{ item }}
                </v-btn>
              </v-list-item-action>
            </v-list-item>
  
            <v-divider></v-divider>
          </template>
        </v-virtual-scroll>
  </v-card>
</template>

<script lang="ts">
import { Component, Vue, Prop } from 'vue-property-decorator'
import { WordsService } from '~/scripts/wordsService'
import { WordleGame } from '~/scripts/wordleGame'

@Component
export default class WordList extends Vue {
    wordList!: string[]
    display!: boolean
    @Prop({ required: true })
    wordleGame!: WordleGame

    findWord(word: string) {
      this.wordList = []
      var tempList = WordsService.wordList;
      var newList:string[] = [];
      var check = true;
      tempList.forEach(x => {

        var temp = x.split(''); 
        var i = 0;
        this.wordleGame.currentWord.text.split('').forEach(e => {
          if(!(e === temp[i] || e === '?')) {
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

    selectWord(word: string) {
      this.clearCurrentWord()
      word.split('').forEach(e => {
        this.setLetter(e)
      });
    }

    setLetter(char: string) {
     this.wordleGame.currentWord.addLetter(char)
    }

    clearCurrentWord() {
      let i = 0;
      while(this.wordleGame.currentWord.length+1 >= i) {
        this.removeLetter()
        i++
      }
    }

    removeLetter() {
      this.wordleGame.currentWord.removeLetter()
    }

    wordListLength() {
      return this.findWord(this.wordleGame.currentWord.text).length
    }

    showDisplay(){
      if(this.display){
        this.display = false;
      }
      this.display = true;
    }
}
</script>
