$TestRecordingFile = Join-Path 'C:\zd\azure-powershell\src\Storage\test' 'Update-AzStorageServiceProperty!V1.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Update-AzStorageServiceProperty!V1' {
    It '__AllParameterSets' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
