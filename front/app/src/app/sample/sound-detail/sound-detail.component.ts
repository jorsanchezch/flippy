import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { Sound } from '../models/sound';
import { SoundService } from '../services/sound.service';

@Component({
  selector: 'app-sound-detail',
  templateUrl: './sound-detail.component.html',
  styleUrls: ['./sound-detail.component.css']
})
export class SoundDetailComponent implements OnInit {
  sound: Sound;

  constructor(
    private route: ActivatedRoute,
    private soundService: SoundService,
    private location: Location
  ) { }

  ngOnInit(): void {
    this.getSound();
  }

  getSound(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.soundService.getSound(id)
      .subscribe(sound => this.sound = sound);
  }

  goBack(): void {
    this.location.back();
  }
}