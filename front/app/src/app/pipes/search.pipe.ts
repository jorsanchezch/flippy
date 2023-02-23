import { Pipe, PipeTransform } from '@angular/core';
import { Sound } from '../sample/models/sound';

@Pipe({
  name: 'search'
})
export class SearchPipe implements PipeTransform {
  transform(sounds: Sound[], query: string): Sound[] {
    if (!query || query === '') {
      return sounds;
    }
    return sounds.filter(sound =>
      sound.name.toLowerCase().includes(query.toLowerCase()));
      // || sound.category.name.toLowerCase().includes(query.toLowerCase()));
  }
}
