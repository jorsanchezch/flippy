import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Sound } from '../models/sound';

@Injectable({
  providedIn: 'root'
})
export class SoundService {
  private soundsUrl = 'api/sounds'; // URL to web api
  private audio!: HTMLAudioElement;

  constructor(private http: HttpClient) { }

  getSounds(): Observable<Sound[]> {
    return this.http.get<Sound[]>(this.soundsUrl);
  }

  getSound(id: number): Observable<Sound> {
    const url = `${this.soundsUrl}/${id}`;
    return this.http.get<Sound>(url);
  }

  playSample(id: number): void {
    if (!this.audio) {
      this.audio = new Audio();
    }
    this.audio.src = `api/sounds/${id}/file`;
    this.audio.play();
  }

  stopSample(): void {
    if (this.audio) {
      this.audio.pause();
      this.audio.currentTime = 0;
    }
  }
}
