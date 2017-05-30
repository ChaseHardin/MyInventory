import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TopNavComponent } from './top-nav.component';
import {By} from "@angular/platform-browser";

describe('TopNavComponent', () => {
  let component: TopNavComponent;
  let fixture: ComponentFixture<TopNavComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TopNavComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TopNavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });

  it('should set inventory route', () => {
    expect(fixture.nativeElement.querySelector('[name=inventoryRoute] a').getAttribute('routerLink')).toEqual('/inventory');
  });

  it('should set home route', () => {
    expect(fixture.nativeElement.querySelector('[name=homeRoute] a').getAttribute('routerLink')).toEqual('/home');
  });

  it('should set brand route', () => {
    expect(fixture.nativeElement.querySelector('[name=brandRoute]').getAttribute('routerLink')).toEqual('/home');
  });

  it('should set manageInventory route', () => {
    expect(fixture.nativeElement.querySelector('[name=manageRoute] a').getAttribute('routerLink')).toEqual('/manage');
  });
});