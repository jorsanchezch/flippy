import { Component, Input } from '@angular/core';
import { Sound } from '../../models/sound';

@Component({
  selector: 'app-sound-item',
  templateUrl: './sound-item.component.html',
  styleUrls: ['./sound-item.component.css']
})
export class SoundItemComponent {
  @Input() sound!: Sound;

  playSound(): void {
    const audio = new Audio(this.sound.audioUrl);
    audio.play();
  }

  stopSound(): void {
    const audio = new Audio(this.sound.audioUrl);
    audio.pause();
    audio.currentTime = 0;
  }
}
