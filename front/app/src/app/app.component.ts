import { Component } from '@angular/core';
import { Sound } from './sample/models/sound';
import { SoundService } from './sample/services/sound.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private soundService: SoundService) {}


  onSearch(query: string) {
    console.log(query);
  }
}
