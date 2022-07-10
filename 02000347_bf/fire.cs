namespace Maple2.Trigger._02000347_bf {
    public static class _fire {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050}, visible: false, arg3: 0, arg4: 0);
                context.SetSkill(triggerIds: new []{7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050}, arg2: false);
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{60002})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050}, visible: false, arg3: 0, arg4: 2);
                context.SetSkill(triggerIds: new []{7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050}, arg2: false);
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650}, visible: false);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class  StateRandomSkillCast : TriggerState {
            internal  StateRandomSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 2f)) {
                    return new State1TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State4TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State6TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State7TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State8TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State9TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State10TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State11TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State12TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State13TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State14TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State15TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State16TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State17TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State18TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State19TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State20TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State21TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State22TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State23TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State24TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State25TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State26TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State27TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State28TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State29TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State30TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State31TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State32TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State33TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State34TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State35TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State36TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State37TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State38TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State39TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State40TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State41TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State42TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State43TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State44TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State45TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State46TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State47TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State48TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State49TimedCreation(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State50TimedCreation(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1TimedCreation : TriggerState {
            internal State1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7001}, arg2: true);
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2TimedCreation : TriggerState {
            internal State2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7002}, arg2: true);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetMesh(triggerIds: new []{3002}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3TimedCreation : TriggerState {
            internal State3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7003}, arg2: true);
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetMesh(triggerIds: new []{3003}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4TimedCreation : TriggerState {
            internal State4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7004}, arg2: true);
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetMesh(triggerIds: new []{3004}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5TimedCreation : TriggerState {
            internal State5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7005}, arg2: true);
                context.SetEffect(triggerIds: new []{605}, visible: true);
                context.SetMesh(triggerIds: new []{3005}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6TimedCreation : TriggerState {
            internal State6TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7006}, arg2: true);
                context.SetEffect(triggerIds: new []{606}, visible: true);
                context.SetMesh(triggerIds: new []{3006}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7TimedCreation : TriggerState {
            internal State7TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7007}, arg2: true);
                context.SetEffect(triggerIds: new []{607}, visible: true);
                context.SetMesh(triggerIds: new []{3007}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8TimedCreation : TriggerState {
            internal State8TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7008}, arg2: true);
                context.SetEffect(triggerIds: new []{608}, visible: true);
                context.SetMesh(triggerIds: new []{3008}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9TimedCreation : TriggerState {
            internal State9TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7009}, arg2: true);
                context.SetEffect(triggerIds: new []{609}, visible: true);
                context.SetMesh(triggerIds: new []{3009}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10TimedCreation : TriggerState {
            internal State10TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7010}, arg2: true);
                context.SetEffect(triggerIds: new []{610}, visible: true);
                context.SetMesh(triggerIds: new []{3010}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11TimedCreation : TriggerState {
            internal State11TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7011}, arg2: true);
                context.SetEffect(triggerIds: new []{611}, visible: true);
                context.SetMesh(triggerIds: new []{3011}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12TimedCreation : TriggerState {
            internal State12TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7012}, arg2: true);
                context.SetEffect(triggerIds: new []{612}, visible: true);
                context.SetMesh(triggerIds: new []{3012}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State13TimedCreation : TriggerState {
            internal State13TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7013}, arg2: true);
                context.SetEffect(triggerIds: new []{613}, visible: true);
                context.SetMesh(triggerIds: new []{3013}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State14TimedCreation : TriggerState {
            internal State14TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7014}, arg2: true);
                context.SetEffect(triggerIds: new []{614}, visible: true);
                context.SetMesh(triggerIds: new []{3014}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State15TimedCreation : TriggerState {
            internal State15TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7015}, arg2: true);
                context.SetEffect(triggerIds: new []{615}, visible: true);
                context.SetMesh(triggerIds: new []{3015}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State16TimedCreation : TriggerState {
            internal State16TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7016}, arg2: true);
                context.SetEffect(triggerIds: new []{616}, visible: true);
                context.SetMesh(triggerIds: new []{3016}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State17TimedCreation : TriggerState {
            internal State17TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7017}, arg2: true);
                context.SetEffect(triggerIds: new []{617}, visible: true);
                context.SetMesh(triggerIds: new []{3017}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State18TimedCreation : TriggerState {
            internal State18TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7018}, arg2: true);
                context.SetEffect(triggerIds: new []{618}, visible: true);
                context.SetMesh(triggerIds: new []{3018}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State19TimedCreation : TriggerState {
            internal State19TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7019}, arg2: true);
                context.SetEffect(triggerIds: new []{619}, visible: true);
                context.SetMesh(triggerIds: new []{3019}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20TimedCreation : TriggerState {
            internal State20TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7020}, arg2: true);
                context.SetEffect(triggerIds: new []{620}, visible: true);
                context.SetMesh(triggerIds: new []{3020}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State21TimedCreation : TriggerState {
            internal State21TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7021}, arg2: true);
                context.SetEffect(triggerIds: new []{621}, visible: true);
                context.SetMesh(triggerIds: new []{3021}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State22TimedCreation : TriggerState {
            internal State22TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7022}, arg2: true);
                context.SetEffect(triggerIds: new []{622}, visible: true);
                context.SetMesh(triggerIds: new []{3022}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State23TimedCreation : TriggerState {
            internal State23TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7023}, arg2: true);
                context.SetEffect(triggerIds: new []{623}, visible: true);
                context.SetMesh(triggerIds: new []{3023}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State24TimedCreation : TriggerState {
            internal State24TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7024}, arg2: true);
                context.SetEffect(triggerIds: new []{624}, visible: true);
                context.SetMesh(triggerIds: new []{3024}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State25TimedCreation : TriggerState {
            internal State25TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7025}, arg2: true);
                context.SetEffect(triggerIds: new []{625}, visible: true);
                context.SetMesh(triggerIds: new []{3025}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State26TimedCreation : TriggerState {
            internal State26TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7026}, arg2: true);
                context.SetEffect(triggerIds: new []{626}, visible: true);
                context.SetMesh(triggerIds: new []{3026}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State27TimedCreation : TriggerState {
            internal State27TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7027}, arg2: true);
                context.SetEffect(triggerIds: new []{627}, visible: true);
                context.SetMesh(triggerIds: new []{3027}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State28TimedCreation : TriggerState {
            internal State28TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7028}, arg2: true);
                context.SetEffect(triggerIds: new []{628}, visible: true);
                context.SetMesh(triggerIds: new []{3028}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State29TimedCreation : TriggerState {
            internal State29TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7029}, arg2: true);
                context.SetEffect(triggerIds: new []{629}, visible: true);
                context.SetMesh(triggerIds: new []{3029}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30TimedCreation : TriggerState {
            internal State30TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7030}, arg2: true);
                context.SetEffect(triggerIds: new []{630}, visible: true);
                context.SetMesh(triggerIds: new []{3030}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State31TimedCreation : TriggerState {
            internal State31TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7031}, arg2: true);
                context.SetEffect(triggerIds: new []{631}, visible: true);
                context.SetMesh(triggerIds: new []{3031}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State32TimedCreation : TriggerState {
            internal State32TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7032}, arg2: true);
                context.SetEffect(triggerIds: new []{632}, visible: true);
                context.SetMesh(triggerIds: new []{3032}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State33TimedCreation : TriggerState {
            internal State33TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7033}, arg2: true);
                context.SetEffect(triggerIds: new []{633}, visible: true);
                context.SetMesh(triggerIds: new []{3033}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State34TimedCreation : TriggerState {
            internal State34TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7034}, arg2: true);
                context.SetEffect(triggerIds: new []{634}, visible: true);
                context.SetMesh(triggerIds: new []{3034}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State35TimedCreation : TriggerState {
            internal State35TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7035}, arg2: true);
                context.SetEffect(triggerIds: new []{635}, visible: true);
                context.SetMesh(triggerIds: new []{3035}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State36TimedCreation : TriggerState {
            internal State36TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7036}, arg2: true);
                context.SetEffect(triggerIds: new []{636}, visible: true);
                context.SetMesh(triggerIds: new []{3036}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State37TimedCreation : TriggerState {
            internal State37TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7037}, arg2: true);
                context.SetEffect(triggerIds: new []{637}, visible: true);
                context.SetMesh(triggerIds: new []{3037}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State38TimedCreation : TriggerState {
            internal State38TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7038}, arg2: true);
                context.SetEffect(triggerIds: new []{638}, visible: true);
                context.SetMesh(triggerIds: new []{3038}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State39TimedCreation : TriggerState {
            internal State39TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7039}, arg2: true);
                context.SetEffect(triggerIds: new []{639}, visible: true);
                context.SetMesh(triggerIds: new []{3039}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State40TimedCreation : TriggerState {
            internal State40TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7040}, arg2: true);
                context.SetEffect(triggerIds: new []{640}, visible: true);
                context.SetMesh(triggerIds: new []{3040}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State41TimedCreation : TriggerState {
            internal State41TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7041}, arg2: true);
                context.SetEffect(triggerIds: new []{641}, visible: true);
                context.SetMesh(triggerIds: new []{3041}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State42TimedCreation : TriggerState {
            internal State42TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7042}, arg2: true);
                context.SetEffect(triggerIds: new []{642}, visible: true);
                context.SetMesh(triggerIds: new []{3042}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State43TimedCreation : TriggerState {
            internal State43TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7043}, arg2: true);
                context.SetEffect(triggerIds: new []{643}, visible: true);
                context.SetMesh(triggerIds: new []{3043}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State44TimedCreation : TriggerState {
            internal State44TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7044}, arg2: true);
                context.SetEffect(triggerIds: new []{644}, visible: true);
                context.SetMesh(triggerIds: new []{3044}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State45TimedCreation : TriggerState {
            internal State45TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7045}, arg2: true);
                context.SetEffect(triggerIds: new []{645}, visible: true);
                context.SetMesh(triggerIds: new []{3045}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State46TimedCreation : TriggerState {
            internal State46TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7046}, arg2: true);
                context.SetEffect(triggerIds: new []{646}, visible: true);
                context.SetMesh(triggerIds: new []{3046}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State47TimedCreation : TriggerState {
            internal State47TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7047}, arg2: true);
                context.SetEffect(triggerIds: new []{647}, visible: true);
                context.SetMesh(triggerIds: new []{3047}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State48TimedCreation : TriggerState {
            internal State48TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7048}, arg2: true);
                context.SetEffect(triggerIds: new []{648}, visible: true);
                context.SetMesh(triggerIds: new []{3048}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State49TimedCreation : TriggerState {
            internal State49TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7049}, arg2: true);
                context.SetEffect(triggerIds: new []{649}, visible: true);
                context.SetMesh(triggerIds: new []{3049}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50TimedCreation : TriggerState {
            internal State50TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7050}, arg2: true);
                context.SetEffect(triggerIds: new []{650}, visible: true);
                context.SetMesh(triggerIds: new []{3050}, visible: true, arg3: 0, arg4: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050}, arg2: false);
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
