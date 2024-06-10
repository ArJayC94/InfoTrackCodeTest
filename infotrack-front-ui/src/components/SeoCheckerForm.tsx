import { useState } from "react";
import Api from "../Api";

export const SeoCheckerForm = () => {
  const [keyword, setKeyword] = useState("");
  const [url, setUrl] = useState("");
  const [result, setResult] = useState("");
  const [status, setStatus] = useState("");

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await Api.seoCheckService.checkSeo(keyword, url);
      setResult(response);
      setStatus("Success");
    } catch (error) {
      setStatus(`Failed to obtain info: ${error.message}`);
    }
  };

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <input
          type="text"
          value={keyword}
          onChange={(e) => setKeyword(e.target.value)}
          placeholder="Keyword"
        />
        <input
          type="text"
          value={url}
          onChange={(e) => setUrl(e.target.value)}
          placeholder="URL"
        />
        <button type="submit">Check SEO</button>
      </form>
      {result && <p>Positions: {result}</p>}
      {status && <p>Status: {status}</p>}
    </div>
  );
};
