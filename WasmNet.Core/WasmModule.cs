namespace WasmNet.Core;

public class WasmModule
{
    public WasmTypeSection? TypeSection { get; set; }
    
    public WasmImportSection? ImportSection { get; set; }

    public WasmFunctionSection? FunctionSection { get; set; }

    public WasmExportSection? ExportSection { get; set; }

    public WasmCodeSection? CodeSection { get; set; }
}