using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class PortfolioManager : IPortfolioService
{
	private IPortfolio _portfolio;

	public PortfolioManager(IPortfolio portfolio)
	{
		_portfolio = portfolio;
	}

	public Portfolio GetById(int id)
	{
		return _portfolio.GetById(id);
	}

	public List<Portfolio> GetList()
	{
		return _portfolio.GetList();
	}

	public List<Portfolio> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<Portfolio> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(Portfolio entity)
	{
		_portfolio.Add(entity);
	}

	public void TRemove(Portfolio entity)
	{
		_portfolio.Remove(entity);
	}

	public void TUpdate(Portfolio entity)
	{
		_portfolio.Update(entity);
	}
}