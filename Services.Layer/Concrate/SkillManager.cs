using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class SkillManager : ISkillService
{
	private ISkill _skill;

	public SkillManager(ISkill skill)
	{
		_skill = skill;
	}

	public Skill GetById(int id)
	{
		return _skill.GetById(id);
	}

	public List<Skill> GetList()
	{
		return _skill.GetList();
	}

	public List<Skill> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<Skill> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(Skill entity)
	{
		_skill.Add(entity);
	}

	public void TRemove(Skill entity)
	{
		_skill.Remove(entity);
	}

	public void TUpdate(Skill entity)
	{
		_skill.Update(entity);
	}
}
