function solve(workers){

    if (workers.dizziness) {
        workers.levelOfHydrated += (workers.experience * workers.weight) * 0.1;
        workers.dizziness = false;
    }
    return workers
}
solve({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true }
  )