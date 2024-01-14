using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class TestimonialManager : ITestimonialService
{
	private ITestimonial _testimonial;

	public TestimonialManager(ITestimonial testimonial)
	{
		_testimonial = testimonial;
	}

	public Testimonial GetById(int id)
	{
		return _testimonial.GetById(id);
	}

	public List<Testimonial> GetList()
	{
		return _testimonial.GetList();
	}

	public List<Testimonial> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<Testimonial> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(Testimonial entity)
	{
		_testimonial.Add(entity);
	}

	public void TRemove(Testimonial entity)
	{
		_testimonial.Remove(entity);
	}

	public void TUpdate(Testimonial entity)
	{
		_testimonial.Update(entity);
	}
}
