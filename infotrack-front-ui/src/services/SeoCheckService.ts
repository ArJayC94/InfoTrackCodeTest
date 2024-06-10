import axios from "axios";

const apiUrl = "http://localhost:8080/api/seochecker";

const SeoCheckService = {
  async checkSeo(keyword: string, url: string): Promise<any> {
    try {
      const response = await axios.get(
        `${apiUrl}?keyword=${keyword}&url=${url}`
      );
      return response.data;
    } catch (error) {
      console.error("Error checking SEO", error);
      throw error;
    }
  },
};

export default SeoCheckService;
