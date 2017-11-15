import { Component, Inject } from '@angular/core';
import { NgModel } from '@angular/forms';
import { Http } from '@angular/http';

@Component({
    selector: 'weeks',
    templateUrl: './weeks.component.html'
})
export class WeeksComponent {
    test = false;
    testString = ""

    public testMethod(){
        this.test = !this.test;
    } 
    
    // public forecasts: WeatherForecast[];

    // constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
    //     http.get(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
    //         this.forecasts = result.json() as WeatherForecast[];
    //     }, error => console.error(error));
    // }
}

// interface WeatherForecast {
//     dateFormatted: string;
//     temperatureC: number;
//     temperatureF: number;
//     summary: string;
// }
