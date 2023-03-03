import { Component, Input } from '@angular/core';
import { Sound } from '../models/sound';

@Component({
  selector: 'app-sound-list',
  templateUrl: './sound-list.component.html',
  styleUrls: ['./sound-list.component.scss']
})
export class SoundListComponent {
  @Input() sounds!: Sound[];

  constructor() { }
}
