import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Sound } from '../models/sound';
import { SoundService } from '../services/sound.service';
import { SoundValidator } from '../validators/sound.validator';

@Component({
  selector: 'app-sound-create',
  templateUrl: './sound-create.component.html',
  styleUrls: ['./sound-create.component.scss']
})
export class SoundCreateComponent implements OnInit {
  soundForm!: FormGroup;
  keyRoots: string[] = ['C', 'D', 'E', 'F', 'G', 'A', 'B'];
  keyMods: string[] = ['Sharp', 'Flat'];
  keyForms: string[] = ['Major', 'Minor'];
  submitted = false;

  constructor(private formBuilder: FormBuilder,
    private http: HttpClient,
    private soundService: SoundService,
    private soundValidator: SoundValidator) { }

  ngOnInit() {
    this.soundForm = this.formBuilder.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      bpm: ['', Validators.required],
      keyRoot: ['', Validators.required],
      keyMod: ['', Validators.required],
      keyForm: ['', Validators.required],
      audioFile: [null, Validators.required]
    });
  }

  get f() { return this.soundForm.controls; }

  onSubmit() {
    this.submitted = true;
    if (this.soundForm.invalid) {
      return;
    }
    
    // const validationResult = this.soundValidator.validate(this.soundForm);

    const formData = new FormData();
    formData.append('name', this.f['name'].value);
    formData.append('description', this.f['description'].value);
    formData.append('bpm', this.f['bpm'].value);
    formData.append('keyRoot', this.f['keyRoot'].value);
    formData.append('keyMod', this.f['keyMod'].value);
    formData.append('keyForm', this.f['keyForm'].value);
    formData.append('audioFile', this.f['audioFile'].value);

    this.soundService.createSound(formData).subscribe((sound: Sound) => {
      console.log('Sound created successfully');
      }, (error) => {
        console.log(error);});
    }

    onFileChange(event: any) {
      if (event.target.files.length > 0) {
      const file = event.target.files[0];
      this.f['audioFile'].setValue(file);
      }
    }
};
