import { Component, OnInit } from '@angular/core';
import { Sound } from '../models/sound';
import { SoundService } from '../services/sound.service';

@Component({
  selector: 'app-sound-grid',
  templateUrl: './sound-grid.component.html',
  styleUrls: ['./sound-grid.component.css']
})
export class SoundGridComponent implements OnInit {
  sounds: Sound[];

  constructor(private soundService: SoundService) { }

  ngOnInit(): void {
    this.getSounds();
  }

  getSounds(): void {
    this.soundService.getSounds()
      .subscribe(sounds => this.sounds = sounds);
  }
}
