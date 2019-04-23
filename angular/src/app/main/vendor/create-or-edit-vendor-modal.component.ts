import { Component, ElementRef, EventEmitter, Injector, Output, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { ModalDirective } from 'ngx-bootstrap';
import { VendorServiceProxy, VendorInput } from '@shared/service-proxies/service-proxies';


@Component({
    selector: 'createOrEditVendorModal',
    templateUrl: './create-or-edit-vendor-modal.component.html'
})
export class CreateOrEditVendorModalComponent extends AppComponentBase {


    @ViewChild('createOrEditModal') modal: ModalDirective;
    @ViewChild('vendorCombobox') vendorCombobox: ElementRef;
    @ViewChild('iconCombobox') iconCombobox: ElementRef;
    @ViewChild('dateInput') dateInput: ElementRef;


    /**
     * @Output dùng để public event cho component khác xử lý
     */
    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    saving = false;

    vendor: VendorInput = new VendorInput();

    constructor(
        injector: Injector,
        private _vendorService: VendorServiceProxy
    ) {
        super(injector);
    }

    show(vendorId?: number | null | undefined): void {
        this.saving = false;


        this._vendorService.getVendorForEdit(vendorId).subscribe(result => {
            this.vendor = result;
            this.modal.show();

        })
    }

    save(): void {
        let input = this.vendor;
        this.saving = true;
        this._vendorService.createOrEditVendor(input).subscribe(result => {
            this.notify.info(this.l('SavedSuccessfully'));
            this.close();
        })

    }

    close(): void {
        this.modal.hide();
        this.modalSave.emit(null);
    }
}
