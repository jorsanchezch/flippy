import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-audio-player',
  template: `
    <audio controls>
      <source [src]="base64" type="audio/mpeg">
    </audio>
  `,
  styleUrls: ['./audio-player.component.scss']

})

export class AudioPlayerComponent {
  @Input() base64!: string;

  playSound() {
    const audio = new Audio("data:audio/wav;base64," + this.base64);
    audio.play();
  }
}
