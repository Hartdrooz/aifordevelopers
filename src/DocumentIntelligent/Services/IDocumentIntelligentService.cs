﻿
using DocumentIntelligent;

namespace Contoso
{
    public interface IDocumentIntelligentService
    {
        Task<List<DocumentModelSummary>> GetModels();

        Task DeleteModel(string id);

        Task<OutputRecordData> AnalyzeDocument(Uri documentUrl, string modelId);
    }
}