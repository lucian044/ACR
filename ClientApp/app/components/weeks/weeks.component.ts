import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'weeks',
    templateUrl: './weeks.component.html'
})
export class WeeksComponent {
    test = false;
    testString = "Luciano"

    public testMethod(input: string){
        this.test = !this.test;
        this.testString = input;
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
