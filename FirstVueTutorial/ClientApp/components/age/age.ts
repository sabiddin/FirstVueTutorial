import Vue from 'vue';
import { Component } from 'vue-property-decorator';
@Component
export default class AgeComponent extends Vue {
    dob: Date = new Date;
    message: string = '';
    getAge() {
        fetch('api/Age/getAge/' + this.dob)
            .then(response => response.json())
            .then(data => {
                this.message = data;
            });
    }

}