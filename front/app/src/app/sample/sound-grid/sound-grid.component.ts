import { Component, OnInit } from '@angular/core';
import { Sound } from '../models/sound';
import { SoundService } from '../services/sound.service';
@Component({
  selector: 'app-sound-grid',
  templateUrl: './sound-grid.component.html',
  styleUrls: ['./sound-grid.component.css']
})
export class SoundGridComponent implements OnInit {
  sounds: Sound[] = [
    {
      id: 1,
      name: 'Acoustic Guitar Chord',
      description: 'A simple acoustic guitar chord played at a moderate tempo.',
      audioUrl: 'https://example.com/audio/acoustic-guitar-chord.mp3',
      bpm: 120,
      keyRoot: 'C',
      keyMod: 'Sharp',
      keyForm: 'Major',
      length: 5,
      instruments: [{ id: 1, name: 'Acoustic Guitar'}, {id: 2, name: 'Electric Guitar'}],
      genres: [{id: 1, name: 'Folk'}, {id: 2, name: 'Country'}, {id: 3, name: 'Pop'}],
      users: [{
        id: 1,
        name: 'John Doe',
        email: 'john@example.com'
      }]
    },
    // Another sound object
    {
      id: 2,
      name: 'Electric Guitar Riff',
      description: 'A simple electric guitar riff played at a moderate tempo.',
      audioUrl: 'https://example.com/audio/electric-guitar-riff.mp3',
      bpm: 150,
      keyRoot: 'B',
      keyMod: 'Flat',
      keyForm: 'Major',
      length: 5,
      instruments: [{ id: 1, name: 'Acoustic Guitar'}, {id: 2, name: 'Electric Guitar'}],
      genres: [{id: 1, name: 'Folk'}, {id: 2, name: 'Country'}, {id: 3, name: 'Pop'}],
      users: [{
        id: 1,
        name: 'John Doe',
        email: 'john@example.com'
      }]
    }
  ];;

  constructor(private soundService: SoundService) { }

  ngOnInit(): void {
    this.getSounds();
  }

  getSounds(): void {
    this.soundService.getSounds()
      .subscribe(sounds => this.sounds = sounds);
  }
}
