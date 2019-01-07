import Vue from 'vue';
import { Component } from 'vue-property-decorator'

@Component
export default class HelloComponent extends Vue {
    message: string = '';
    first: string = '100';
    second: string = '200';
    result: number = 0;
    mounted() {
        this.add();
    }
    add() {
        //this.result = parseInt(this.first) + parseInt(this.second);
        fetch('api/Hello/add/' + this.first + '/' + this.second)
            .then(response => response.json())
            .then(data => {
                this.result = data;
            });
    }
}