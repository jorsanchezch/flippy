import { Component, OnInit, ViewChild } from '@angular/core';
import { Sound } from '../models/sound';
import { SoundService } from '../services/sound.service';
import { SoundCreateComponent } from '../sound-create/sound-create.component';

@Component({
  selector: 'app-sound-grid',
  templateUrl: './sound-grid.component.html',
  styleUrls: ['./sound-grid.component.scss']
})
export class SoundGridComponent implements OnInit {
  currentPage = 1;
  pageSize = 10;

  sounds!: Sound[];

  constructor(private soundService: SoundService) { }

  ngOnInit(): void {
    this.getSounds();
  }

  getSounds(): void {
    this.soundService.getSounds()
      .subscribe(sounds => this.sounds = sounds);
  }
}
