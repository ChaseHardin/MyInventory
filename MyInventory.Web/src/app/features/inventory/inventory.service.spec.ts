import { TestBed, inject } from '@angular/core/testing';
import { InventoryService } from './inventory.service';
import { HttpModule } from "@angular/http";

describe('InventoryService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [InventoryService ],
      imports: [HttpModule]
    });
  });

  it('should ...', inject([InventoryService], (service: InventoryService) => {
    expect(service).toBeTruthy();
  }));
});
