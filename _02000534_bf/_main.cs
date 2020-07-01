namespace Maple2.Trigger._02000534_bf {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008}, arg2: true);
                context.SetEffect(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009}, arg2: false);
                context.CreateMonster(arg1: new[] {508, 509, 510, 511, 716, 715, 713, 717, 718, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712}, arg2: true);
                context.MoveNpc(arg1: 508, arg2: "MS2PatrolData_4000");
                context.MoveNpc(arg1: 509, arg2: "MS2PatrolData_4001");
                context.MoveNpc(arg1: 511, arg2: "MS2PatrolData_4002");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701}, arg2: 0)) {
                    return new Statestart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEventUI(arg1: 1, arg2: "$02000534_BF__MAIN__0$", arg3: 3000);
                context.SetPortal(arg1: 2, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State첫번째몬스터전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째몬스터전투시작 : TriggerState {
            internal State첫번째몬스터전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003132, 10003133, 10003134, 10003135}, arg2: 0);
                context.CreateMonster(arg1: new[] {501, 520, 521, 522, 523}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 523, msg: "$02000534_BF__MAIN__1$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 520, msg: "$02000534_BF__MAIN__2$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 521, msg: "$02000534_BF__MAIN__3$", duration: 3500, delayTick: 1500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {501, 520, 521, 522, 523})) {
                    return new State첫번째몬스터처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째몬스터처치 : TriggerState {
            internal State첫번째몬스터처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8000}, arg2: true);
                context.SetMesh(arg1: new[] {7000}, arg2: false);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__4$");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {707}, arg2: 0)) {
                    return new State하렌등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌등장 : TriggerState {
            internal State하렌등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_smile", duration: 4000, script: "$02000534_BF__MAIN__5$");
                context.CreateMonster(arg1: new[] {502, 524, 525, 526, 527}, arg2: true, arg3: 100);
                context.AddBalloonTalk(spawnPointId: 502, msg: "$02000534_BF__MAIN__6$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 527, msg: "$02000534_BF__MAIN__7$", duration: 3500, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State하렌등장2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌등장2 : TriggerState {
            internal State하렌등장2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__8$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State하렌등장3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌등장3 : TriggerState {
            internal State하렌등장3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_smile", duration: 4000, script: "$02000534_BF__MAIN__9$");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {502, 524, 525, 526, 527})) {
                    return new State두번째몬스터처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째몬스터처치 : TriggerState {
            internal State두번째몬스터처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8005}, arg2: true);
                context.SetMesh(arg1: new[] {7005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {703}, arg2: 0)) {
                    return new State첫번째연구실몬스터정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째연구실몬스터정리 : TriggerState {
            internal State첫번째연구실몬스터정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 713, msg: "$02000534_BF__MAIN__10$", duration: 3500, delayTick: 2000);
                context.CreateMonster(arg1: new[] {518, 519, 528}, arg2: true, arg3: 500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {518, 519, 528})) {
                    return new State오브젝트설명1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트설명1 : TriggerState {
            internal State오브젝트설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 713, msg: "$02000534_BF__MAIN__11$", duration: 3500, delayTick: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State방해1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해1 : TriggerState {
            internal State방해1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02000534_BF__MAIN__12$", duration: 3500, delayTick: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State첫번째연구실나오기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째연구실나오기 : TriggerState {
            internal State첫번째연구실나오기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7001}, arg2: false);
                context.SetEffect(arg1: new[] {8001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {708}, arg2: 0)) {
                    return new State두번째전투판몬스터생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째전투판몬스터생성 : TriggerState {
            internal State두번째전투판몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {503, 529, 530, 531, 532}, arg2: true, arg3: 500);
                context.AddBalloonTalk(spawnPointId: 503, msg: "$02000534_BF__MAIN__13$", duration: 3500, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {503, 529, 530, 531, 532})) {
                    return new State두번째연구소이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째연구소이동 : TriggerState {
            internal State두번째연구소이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {714}, arg2: true);
                context.SetEffect(arg1: new[] {8006}, arg2: true);
                context.SetMesh(arg1: new[] {7006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {704}, arg2: 0)) {
                    return new State두번째연구실몬스터정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째연구실몬스터정리 : TriggerState {
            internal State두번째연구실몬스터정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 714, msg: "$02000534_BF__MAIN__14$", duration: 3500, delayTick: 500);
                context.MoveNpc(arg1: 714, arg2: "MS2PatrolData_4003");
                context.CreateMonster(arg1: new[] {516, 517, 5516}, arg2: true, arg3: 500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {516, 517, 5516})) {
                    return new State두번째연구실몬스터정리2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째연구실몬스터정리2 : TriggerState {
            internal State두번째연구실몬스터정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {714});
                context.SetInteractObject(arg1: new[] {10003133}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003133}, arg2: 0)) {
                    return new State오브젝트설명2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트설명2 : TriggerState {
            internal State오브젝트설명2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003133}, arg2: 0);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02000534_BF__MAIN__15$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State두번째연구실나오기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째연구실나오기 : TriggerState {
            internal State두번째연구실나오기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02000534_BF__MAIN__16$", duration: 3500, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세번째전투판(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투판 : TriggerState {
            internal State세번째전투판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7002}, arg2: false);
                context.SetEffect(arg1: new[] {8002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {709}, arg2: 0)) {
                    return new State세번째전투판몬스터생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투판몬스터생성 : TriggerState {
            internal State세번째전투판몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {504, 533}, arg2: true, arg3: 500);
                context.AddBalloonTalk(spawnPointId: 504, msg: "$02000534_BF__MAIN__17$", duration: 3500, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {504, 533})) {
                    return new State세번째몬스터처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째몬스터처치 : TriggerState {
            internal State세번째몬스터처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8007}, arg2: true);
                context.SetMesh(arg1: new[] {7007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {705}, arg2: 0)) {
                    return new State세번째연구소이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째연구소이동 : TriggerState {
            internal State세번째연구소이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {514, 515}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 718, msg: "$02000534_BF__MAIN__18$", duration: 3500);
                context.AddBalloonTalk(spawnPointId: 715, msg: "$02000534_BF__MAIN__19$", duration: 3500, delayTick: 500);
                context.AddBalloonTalk(spawnPointId: 715, msg: "$02000534_BF__MAIN__20$", duration: 3500, delayTick: 4000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {514, 515})) {
                    return new State방해3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해3 : TriggerState {
            internal State방해3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 717, msg: "$02000534_BF__MAIN__21$", duration: 3500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State방해33(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해33 : TriggerState {
            internal State방해33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02000534_BF__MAIN__22$", duration: 3500, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State네번째전투판(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째전투판 : TriggerState {
            internal State네번째전투판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7003}, arg2: false);
                context.SetEffect(arg1: new[] {8003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {710}, arg2: 0)) {
                    return new State네번째몬스터처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째몬스터처치 : TriggerState {
            internal State네번째몬스터처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {505, 534, 535, 536, 537}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 536, msg: "$02000534_BF__MAIN__23$", duration: 3500, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {505, 534, 535, 536, 537})) {
                    return new State네번째연구소로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째연구소로이동 : TriggerState {
            internal State네번째연구소로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8008}, arg2: true);
                context.SetMesh(arg1: new[] {7008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {706}, arg2: 0)) {
                    return new State네번째연구소정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째연구소정리 : TriggerState {
            internal State네번째연구소정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {512, 513, 5513}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 716, msg: "$02000534_BF__MAIN__24$", duration: 3500, delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 716, msg: "$02000534_BF__MAIN__25$", duration: 3500, delayTick: 4500);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__26$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State컴퓨터조사하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State컴퓨터조사하기 : TriggerState {
            internal State컴퓨터조사하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_smile", duration: 4000, script: "$02000534_BF__MAIN__27$");
                context.AddBalloonTalk(spawnPointId: 716, msg: "$02000534_BF__MAIN__28$", duration: 3500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {512, 513, 5513})) {
                    return new State4번연구실모두정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번연구실모두정리 : TriggerState {
            internal State4번연구실모두정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003135}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003135}, arg2: 0)) {
                    return new State오브젝트설명4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트설명4 : TriggerState {
            internal State오브젝트설명4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02000534_BF__MAIN__29$", duration: 3000);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02000534_BF__MAIN__30$", duration: 3500, delayTick: 3000);
                context.SetSceneSkip(arg1: "방해4", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State방해4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해4 : TriggerState {
            internal State방해4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.RemoveBalloonTalk(spawnPointId: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State방해44(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해44 : TriggerState {
            internal State방해44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__31$");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02000534_BF__MAIN__32$", duration: 3500, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마지막전투판(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막전투판 : TriggerState {
            internal State마지막전투판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7004}, arg2: false);
                context.SetEffect(arg1: new[] {8004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {702}, arg2: 0)) {
                    return new State보스등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7004}, arg2: true);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__33$");
                context.CreateMonster(arg1: new[] {507}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 507, msg: "$02000534_BF__MAIN__34$", duration: 3500, delayTick: 1500);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 507) <= 0.50f) {
                    return new State업그레이드시작(context);
                }

                if (context.MonsterDead(arg1: new[] {507})) {
                    return new State포탈생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State업그레이드시작 : TriggerState {
            internal State업그레이드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15, arg4: true);
                context.CreateMonster(arg1: new[] {9901, 9902, 9903, 9904}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 507, msg: "$02000534_BF__MAIN__35$", duration: 3500, delayTick: 500);
                context.SetEventUI(arg1: 1, arg2: "$02000534_BF__MAIN__36$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State업그레이드성공체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State업그레이드성공체크 : TriggerState {
            internal State업그레이드성공체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State자폭스킬(context);
                }

                if (context.MonsterDead(arg1: new[] {9901, 9902, 9903, 9904})) {
                    return new State실패(context);
                }

                if (context.MonsterDead(arg1: new[] {507})) {
                    return new State포탈생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자폭스킬 : TriggerState {
            internal State자폭스킬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 507, msg: "$02000534_BF__MAIN__37$", duration: 3500, delayTick: 500);
                context.SetAiExtraData(key: "bomb", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {507})) {
                    return new State포탈생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 507, msg: "$02000534_BF__MAIN__38$", duration: 3500, delayTick: 500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {507})) {
                    return new State포탈생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탈생성 : TriggerState {
            internal State포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15, arg4: false);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 3000, script: "$02000534_BF__MAIN__39$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State포탈생성2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탈생성2 : TriggerState {
            internal State포탈생성2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000534_BF__MAIN__40$", arg3: 3000);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}