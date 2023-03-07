import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Sound } from '../models/sound';
import { env } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SoundService {
  private soundsUrl = env.apiUrl + 'api/sound'; // URL to web api
  private audio!: HTMLAudioElement;

  constructor(private http: HttpClient) { }

  getSounds(): Observable<Sound[]> {
    return this.http.get<Sound[]>(this.soundsUrl);
  }

  getSound(id: number): Observable<Sound> {
    const url = `${this.soundsUrl}/${id}`;
    return this.http.get<Sound>(url);
  }

  createSound(formData: FormData): Observable<Sound> {
    return this.http.post<Sound>(this.soundsUrl, formData);
  }
}
