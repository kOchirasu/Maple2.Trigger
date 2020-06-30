using System;

namespace Maple2.Trigger._02020300_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990002, key: "Spawn", value: 0);
                context.SetUserValue(triggerID: 99990003, key: "RandomBomb", value: 0);
                context.SetUserValue(triggerID: 99990004, key: "Laser", value: 0);
                context.SetUserValue(triggerID: 99990005, key: "elevator", value: 0);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10002185}, arg2: 0);
                context.EnableSpawnPointPc(spawnPointID: 100, isEnable: true);
                context.EnableSpawnPointPc(spawnPointID: 101, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 102, isEnable: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "901")) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "902")) {
                    context.SetEventUI(arg1: 1, arg2: "$02020300_BF__MAIN__0$", arg3: new int[] {5000});
                    context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: false);
                    context.State = new State추가대사_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_01 : TriggerState {
            internal State추가대사_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetUserValue(triggerID: 99990004, key: "Laser", value: 1);
                    context.SideNpcTalk(type: "talk", npcID: 29500101, illust: "ArcheonBlack_Normal",
                        script: "$02020300_BF__MAIN__1$", duration: 5000);
                    context.State = new State추가대사_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_02 : TriggerState {
            internal State추가대사_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102, 103})) {
                    context.SideNpcTalk(type: "talk", npcID: 29000170, illust: "ArcaneBlader_normal",
                        script: "$02020300_BF__MAIN__2$", duration: 5000);
                    context.State = new State추가대사_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_03 : TriggerState {
            internal State추가대사_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_normal",
                        script: "$02020300_BF__MAIN__3$", duration: 5000);
                    context.State = new State엘리베이터_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_체크 : TriggerState {
            internal State엘리베이터_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: "talk", npcID: 29000170, illust: "ArcaneBlader_normal",
                        script: "$02020300_BF__MAIN__4$", duration: 5000);
                    context.State = new State엘리베이터_스위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_스위치 : TriggerState {
            internal State엘리베이터_스위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002185}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002185}, arg2: 0)) {
                    context.State = new State엘리베이터_활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_활성화 : TriggerState {
            internal State엘리베이터_활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "903")) {
                    context.State = new State아르케온_탑승_가이드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르케온_탑승_가이드 : TriggerState {
            internal State아르케온_탑승_가이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020300_BF__MAIN__5$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "711")) {
                    context.SetUserValue(triggerID: 99990005, key: "elevator", value: 1);
                    context.EnableSpawnPointPc(spawnPointID: 100, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 101, isEnable: true);
                    context.EnableSpawnPointPc(spawnPointID: 102, isEnable: false);
                    context.State = new State레이저_패턴_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레이저_패턴_시작 : TriggerState {
            internal State레이저_패턴_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "904")) {
                    context.State = new State갈림길_전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State갈림길_전투 : TriggerState {
            internal State갈림길_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201, 202, 203, 204}, arg2: false);
                context.SetActor(arg1: 9001, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_end");
                context.SetMesh(arg1: new int[] {1001}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "905")) {
                    context.State = new State짜투리_전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State짜투리_전투 : TriggerState {
            internal State짜투리_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {301, 302, 303, 304}, arg2: false);
                context.SetMesh(arg1: new int[] {2001, 2002, 2003, 2004}, arg2: true);
                context.SetMesh(arg1: new int[] {30000, 30010, 30020, 30030}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "911")) {
                    context.State = new State웨이브_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브_시작 : TriggerState {
            internal State웨이브_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 29000170, illust: "ArcaneBlader_unfair",
                    script: "$02020300_BF__MAIN__6$", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetMesh(arg1: new int[] {2001, 2002, 2003, 2004}, arg2: false);
                    context.SetMesh(arg1: new int[] {30000, 30010, 30020, 30030}, arg2: false);
                    context.State = new State추가대사_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_04 : TriggerState {
            internal State추가대사_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 29500101, illust: "ArcheonBlack_Normal",
                    script: "$02020300_BF__MAIN__7$", duration: 5000);
                context.SetUserValue(triggerID: 99990002, key: "Spawn", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnRoomEnd", value: 1)) {
                    context.SetActor(arg1: 9001, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_start");
                    context.State = new State길열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State길열림 : TriggerState {
            internal State길열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1001}, arg2: false);
                context.SetMesh(arg1: new int[] {2001, 2002, 2003, 2004}, arg2: true);
                context.SetMesh(arg1: new int[] {30000, 30010, 30020, 30030}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "921")) {
                    context.State = new State지뢰방_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지뢰방_시작 : TriggerState {
            internal State지뢰방_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 100, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 101, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 102, isEnable: true);
                context.SetActor(arg1: 9002, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_end");
                context.SetActor(arg1: 9003, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_end");
                context.SetActor(arg1: 9004, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_end");
                context.SetMesh(arg1: new int[] {5001}, arg2: false);
                context.SetMesh(arg1: new int[] {3001, 3002, 3003}, arg2: true);
                context.SetUserValue(triggerID: 99990003, key: "RandomBomb", value: 1);
                context.SideNpcTalk(type: "talk", npcID: 29500101, illust: "ArcheonBlack_Normal",
                    script: "$02020300_BF__MAIN__8$", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State추가대사_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_05 : TriggerState {
            internal State추가대사_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 29000170, illust: "ArcaneBlader_normal",
                    script: "$02020300_BF__MAIN__9$", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State추가대사_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추가대사_06 : TriggerState {
            internal State추가대사_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_normal",
                    script: "$02020300_BF__MAIN__10$", duration: 5000);
            }

            public override void Execute() {
                if (context.UserValue(key: "RandomBombEnd", value: 1)) {
                    context.SetUserValue(triggerID: 99990004, key: "Laser", value: 0);
                    context.State = new State보스전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전 : TriggerState {
            internal State보스전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 29000170, illust: "ArcaneBlader_normal",
                    script: "$02020300_BF__MAIN__11$", duration: 5000);
                context.SetActor(arg1: 9002, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_start");
                context.SetMesh(arg1: new int[] {3001}, arg2: false);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990005, key: "elevator", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}