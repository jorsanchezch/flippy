import { AbstractControl, FormGroup } from '@angular/forms';
import { Validator } from 'fluentvalidation-ts';
import { Sound } from '../models/sound';

export class SoundValidator extends Validator<Sound>{

    constructor() {
      super();
  
      this.ruleFor('name')
        .notEmpty()
        .withMessage('Name is required')
        .matches(/^[a-zA-Z0-9_ ]*$/)
        .withMessage('Name can only contain alphanumeric characters and underscores');
  
      this.ruleFor('description')
        .notEmpty()
        .withMessage('Description is required')
        .maxLength(200)
        .withMessage('Description cannot exceed 200 characters');
  
      this.ruleFor('bpm')
        .greaterThanOrEqualTo(30)
        .withMessage('BPM must be at least 30')
        .lessThanOrEqualTo(300)
        .withMessage('BPM cannot exceed 300');
  
      this.ruleFor('keyRoot')
        .notEmpty()
        .withMessage('Key root is required')
        .matches(/^[A-G]$/)
        .withMessage('Key root must be a valid note from A to G');
  
      this.ruleFor('keyMod')
        .notEmpty()
        .withMessage('Key mod is required')
        .matches(/^(Sharp|Flat)$/)
        .withMessage('Key mod must be either Sharp or Flat');
  
      this.ruleFor('keyForm')
        .notEmpty()
        .withMessage('Key form is required')
        .matches(/^(Major|Minor)$/)
        .withMessage('Key form must be either Major or Minor');
  
      this.ruleFor('audioFile')
        .notEmpty()
        .withMessage('Audio file is required');
    }
}
