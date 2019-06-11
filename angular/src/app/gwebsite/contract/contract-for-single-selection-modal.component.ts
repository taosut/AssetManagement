//

import { AfterViewInit, Component, ElementRef, Injector, OnInit, ViewChild, Output, EventEmitter } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';
import * as _ from 'lodash';
import { LazyLoadEvent } from 'primeng/components/common/lazyloadevent';
import { Paginator } from 'primeng/components/paginator/paginator';
import { Table } from 'primeng/components/table/table';
import { ContractServiceProxy } from '@shared/service-proxies/service-proxies';
import { CreateOrEditContractModalComponent } from './create-or-edit-contract-modal.component';
import { ViewContractModalComponent } from './view-contract-modal.component';
import { ModalDirective } from 'ngx-bootstrap';
@Component({
    selector:'singleSelectContractModal',
    templateUrl: './contract-for-single-selection-modal.component.html',
    animations: [appModuleAnimation()]
})
export class ContractSingleSelectionModalComponent extends AppComponentBase implements AfterViewInit, OnInit {

    /**
     * @ViewChild là dùng get control và call thuộc tính, functions của control đó
     */
    @ViewChild('dataTable') dataTable: Table;
    @ViewChild('paginator') paginator: Paginator;
    @ViewChild('createOrEditModal') modal: ModalDirective;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    saving = false;
    allowLoad=false
    /**
     * tạo các biến dể filters
     */
    contractName: string;

    constructor(
        injector: Injector,
        private _contractService: ContractServiceProxy,
        private _activatedRoute: ActivatedRoute,
    ) {
        super(injector);
    }

    /**
     * Hàm xử lý trước khi View được init
     */
    ngOnInit(): void {
       
    }

    /**
     * Hàm xử lý sau khi View được init
     */
    ngAfterViewInit(): void {
        setTimeout(() => {
            this.init();
        });
    }

    /**
     * Hàm get danh sách contract
     * @param event
     */
    getContracts(event?: LazyLoadEvent) {
        if (!this.paginator || !this.dataTable) {
            return;
        }

        //show loading trong gridview
        this.primengTableHelper.showLoadingIndicator();

        /**
         * mặc định ban đầu lấy hết dữ liệu nên dữ liệu filter = null
         */

        this.reloadList(null, event);
        this.allowLoad=true
    }

    reloadList(contractName, event?: LazyLoadEvent) {
        if(! this.allowLoad) return
        this._contractService.getContractsByFilter(contractName, this.primengTableHelper.getSorting(this.dataTable),
            this.primengTableHelper.getMaxResultCount(this.paginator, event),
            this.primengTableHelper.getSkipCount(this.paginator, event),
        ).subscribe(result => {
            this.primengTableHelper.totalRecordsCount = result.totalCount;
            this.primengTableHelper.records = result.items;
            this.primengTableHelper.hideLoadingIndicator();
        });
    }

    deleteContract(id): void {
        this._contractService.deleteContract(id).subscribe(() => {
            this.reloadPage();
        })
    }

    init(): void {
        //get params từ url để thực hiện filter
        this._activatedRoute.params.subscribe((params: Params) => {
            console.log('params passing: '+JSON.stringify(params['code']))
            this.contractName = params['name'] || '';
            this.reloadList(this.contractName, null);
        });
    }

    reloadPage(): void {
        this.paginator.changePage(this.paginator.getPage());
    }

    applyFilters(): void {
        //truyền params lên url thông qua router
        this.reloadList(this.contractName, null);

        if (this.paginator.getPage() !== 0) {
            this.paginator.changePage(0);
            return;
        }
    }

    save(): void {
      
        this.saving = true;
       
        this.close();

    }

    close(): void {
        this.modal.hide();       
    }

   show(){
    this.modal.show();
   }
  
   onItemChecked(item){
       this.modalSave.emit(item)
       this.modal.hide()
   }
    /**
     * Tạo pipe thay vì tạo từng hàm truncate như thế này
     * @param text
     */
    truncateString(text): string {
        return abp.utils.truncateStringWithPostfix(text, 32, '...');
   
}
}
