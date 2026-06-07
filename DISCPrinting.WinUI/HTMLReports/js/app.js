const dataDict = {
    DocumentNo: 'HcP-001385-002',
    Version: '005',
    Owner: 'HcP/MFE1.11 Production Engineer',
    Date: '11-09-2025',
    BatchId: '260313A941',
    Department: 'HcP/MFE1.11',
    ProcessOwner: 'HcP/MFE1.12',
    User: 'Nguyen Van A',
    ArticleNumberCoil: '0320800410',
    ArticleNumberDB: '1260200832',
    ArticleNumberFB: '0320800410',
    BatchNumberFB: '260313A941',
    BatchNumberDB: '260313A941',
    TrackNo: '1',
    TrackNo2: '21',
    CoilBatch: '535136/948',
    ToolID: 'T0092',
    DeburringTime: 'DISC   15min',
    Machine: '0830',
    BoxNo1: '1',
    BoxNo2: '21',
    TrackMachineToolID: '1-0830-T0092',
    ArticleNumberVersion: '1260.200.832 001',
    Step: '4200',
    BatchNoStep: '260313A941  4200',
    BatchH: 'CF47-674D',
    QuantityQ: '03',
    PartNo: '0320.901.072',
    DateBoxID: '2026-04-03/14-01-38',
    MeltBatch: '535136',
    RollingBatch: '948',
    RingNoCoil: '0026',
    MaterialNo: '0320.800.526',
    Quantity: '23100',
    ProductionVersion: '001',
    StorageNo: '$21i',
    BookingNo1: '1',
    BookingNo2: '2'
};

function fillDataToSpans(dictionary) {
    const elements = document.querySelectorAll('[data-value]');

    elements.forEach((el) => {
        const key = el.getAttribute('data-value');
        if (el.classList.contains('barcode') && dictionary.hasOwnProperty(key)) {
            el.setAttribute('jsbarcode-value', dictionary[key]);
        } else if (dictionary.hasOwnProperty(key)) {
            el.innerText = dictionary[key];
        } else {
            console.warn(`No value found for key: ${key}`);
        }
    });
};

function updatePrintData(dictionary) {
    fillDataToSpans(dictionary);
    JsBarcode(".barcode").init();
};

function generateDynamicTable(data, containerId, tableOptions = {
    className: 'w-100',
    showHeader: true
}) {
    const container = document.getElementById(containerId);
    if (!container || !data || data.length === 0) return;
    tableOptions.showHeader = tableOptions.showHeader ?? true;

    const table = document.createElement('table');
    table.className = tableOptions.className;

    const columns = Object.keys(data[0]);

    if (tableOptions.showHeader) {
        const thead = document.createElement('thead');
        const headerRow = document.createElement('tr');
        columns.forEach(colName => {
            const th = document.createElement('th');
            th.innerText = colName;
            th.className = "center";
            headerRow.appendChild(th);
        });
        thead.appendChild(headerRow);
        table.appendChild(thead);
    }

    const tbody = document.createElement('tbody');
    data.forEach(rowData => {
        const tr = document.createElement('tr');
        columns.forEach(col => {
            const td = document.createElement('td');
            let text = rowData[col] !== null ? rowData[col] : "";
            if (text != "" && text.startsWith('td.class')) {
                applyConfigToTd(td, text);
            }
            else {
                td.innerText = text;
            }
            tr.appendChild(td);
        });
        tbody.appendChild(tr);
    });
    table.appendChild(tbody);

    container.innerHTML = '';
    container.appendChild(table);
};

function applyConfigToTd(td, configString) {
    if (!td || !configString) return;
    const classMatch = configString.match(/td\.class="([^"]+)"/);
    if (classMatch && classMatch[1]) {
        td.className = classMatch[1];
    }
    const valueMatch = configString.match(/value="([^"]*)"/);
    if (valueMatch && valueMatch[1] !== undefined) {
        td.innerText = valueMatch[1];
    }
};

document.addEventListener('DOMContentLoaded', () => {
    fillDataToSpans(dataDict);
    JsBarcode('.barcode').init();
});