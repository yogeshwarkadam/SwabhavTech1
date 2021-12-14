import { Pipe, PipeTransform } from '@angular/core';


@Pipe({
  name: 'cgpaToColor'
})
export class CgpaToColorPipe implements PipeTransform {

  transform(value: number ): string {
   if (value>7) {
     return "green";
   }
   else if (value <7) {
     return "red";
   } else {
     return "yellow";
   }
  
  }

}
